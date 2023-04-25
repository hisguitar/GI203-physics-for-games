using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject enemy;
    public Transform shootPoint;
    public Rigidbody2D bulletPrefab;
    public AudioClip cannonSound;

    private void Update()
    {
        // Mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Position of Mouse click
            Ray ray = Camera.main!.ScreenPointToRay(Input.mousePosition);

            // Show raycast (If you want to see where you shoot (Can only be viewed in 3D view))
            // Debug.DrawRay(ray.origin, ray.direction * 100f, Color.green, 100);
            
            RaycastHit2D hit2d = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            
            // Raycast hit something
            if (hit2d.collider != null)
            {
                // Move enemy to the click
                enemy.transform.position = new Vector2(hit2d.point.x, hit2d.point.y);
                
                // Calculate direction and speed
                Vector2 projectileVelocity = CalculateProjectileVelocity(shootPoint.position, hit2d.point, 1f);

                Rigidbody2D fireBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(cannonSound, gameObject.transform.position); // Cannon Sound

                fireBullet.velocity = projectileVelocity;
            }
        }
        // Cannon follow mouse
        Vector3 mousePosition = Camera.main!.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mousePosition - shootPoint.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        shootPoint.rotation = Quaternion.Euler(0, 0, angle);
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin; // Find distance between cannon and bullet

        float disX = distance.x;
        float disY = distance.y;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        Vector2 result = new Vector2(velocityX, velocityY);

        return result;
    }
}