
function Update () {
	if(Input.GetKey(KeyCode.UpArrow))
		transform.Translate(Vector3(0,0,1));
	if(Input.GetKey(KeyCode.DownArrow))
		transform.Translate(Vector3(0,0,-1));
	if(Input.GetKey(KeyCode.RightArrow))
		transform.Rotate(Vector3(0,1,0));
	if(Input.GetKey(KeyCode.LeftArrow))
		transform.Rotate(Vector3(0,-1,0));
	
}
