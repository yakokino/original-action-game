#pragma strict
// Target Object
var targetObject:GameObject;

// Use this for initialization
function Start () {
}
	
// Update is called once per frame
function Update () {
    // 現在位置を座標に代入
    transform.position = targetObject.transform.position;
    transform.rotation.y = targetObject.transform.rotation.y;
    
    // Z軸修正
    transform.position.z = -8;

    
    
}