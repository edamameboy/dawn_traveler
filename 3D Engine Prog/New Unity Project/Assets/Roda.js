
function Update () {
	if(Input.GetKey(KeyCode.UpArrow))
		transform.Rotate(Vector3(10,0,0));
	if(Input.GetKey(KeyCode.DownArrow))
		transform.Rotate(Vector3(-10,0,0));
}
