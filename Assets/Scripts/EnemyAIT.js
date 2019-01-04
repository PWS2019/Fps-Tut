public var Target : Transform;    
public var Projectile : Transform;
  
public var MaximumLookDistance : float = 15;
public var MaximumAttackDistance : float = 10;
public var FollowSpeed : float = 5;
public var MinimumDistanceFromPlayer : float = 2;
  
public var RotationDamping : float = 2;
public var MoveSpeed : float = 1; 
function Update ()  {
  
    var distance = Vector3.Distance(Target.position, transform.position);
  
    if(distance <= MaximumLookDistance) {
        LookAtTarget ();
  
        if(distance <= MaximumAttackDistance)
            AttackAndFollowTarget (distance);
    }   
}
  
  
function LookAtTarget () {
    var dir = Target.position - transform.position;
    dir.y = 0;
    var rotation = Quaternion.LookRotation(dir);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * RotationDamping);
}
  
  
function AttackAndFollowTarget (distance : float) {
    if(distance > MinimumDistanceFromPlayer)
        transform.Translate((Target.position - transform.position).normalized * MoveSpeed * Time.deltaTime);
  
    Instantiate(Projectile, transform.position + (Target.position - transform.position).normalized, Quaternion.LookRotation(Target.position - transform.position));
}