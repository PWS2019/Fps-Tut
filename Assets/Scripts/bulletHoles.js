// JavaScript source code
var bulletTex = GameObject[]; // creates an array to use random textures of bullet holes

function Update() {

  
    var fwd = transform.TransformDirection(Vector3.forward); //casts our raycast in the forward direction
    var hit = RaycastHit;
    

    Debug.DrawRay(transform.position, fwd * 10, Color.green); //drays our raycast and gives it a green color and a length of 10 meters

    if (Input.GetButton("Fire1") && Physics.Raycast(transform.position, fwd, hit, 10)) { //when we left click and our raycast hits something
        Instantiate(bulletTex[Random.Range(0, 1)], hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));//then we'll instantiate a random bullet hole texture from our array and apply it where we click and adjust// the position and rotation of textures to match the object being hit
                
    }

    
}
