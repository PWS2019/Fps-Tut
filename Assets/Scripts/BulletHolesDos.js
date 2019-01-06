// JavaScript source code

var BulletTexture: GameObject;

clone = Instantiate(BulletTexture, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal)); Destroy(clone.gameObject, 5); clone.transform.parent = hit.transform;