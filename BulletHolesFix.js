// JavaScript source code
if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), hit)) {
    Instantiate(TheBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
}