using UnityEngine;
using System.Collections;

public class clickNewButtons : MonoBehaviour {

	public int num;
	public float scaleX;
	public float scaleY;
	public float scaleZ;
	public float Sub;
	public int newScene;
	public float Control;
	private GameObject privatizator;

	void OnMouseDrag(){
		transform.localScale = new Vector3(scaleX-Sub,scaleY-Sub,scaleZ-Sub);
		Control = 1;
		privatizator.SetActive(true);
        
	}

	void OnMouseUp(){		
		transform.localScale = new Vector3 (scaleX + Sub, scaleY + Sub, scaleZ + Sub);
		Control = 2;
		privatizator.SetActive (false);
	
	}

	void Start () {
		scaleX = transform.localScale.x;
		scaleY = transform.localScale.y;
		scaleZ = transform.localScale.z;
		Sub = transform.localScale.x/20;
		privatizator = GameObject.FindGameObjectWithTag("excroto"); 
		privatizator.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Control == 1)
        {
            Vector2 mp = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,Input.mousePosition.y));
			if (GameObject.FindGameObjectWithTag("CaminhoRed").GetComponent<BoxCollider2D>().OverlapPoint(mp)) 
            {
				newScene = 1;

            }
			else if (GameObject.FindGameObjectWithTag("CaminhoAmarelo").GetComponent<CircleCollider2D>().OverlapPoint(mp)) 
			{
				newScene = 2;
			}
			else if(GameObject.FindGameObjectWithTag("CaminhoGreen").GetComponent<BoxCollider2D>().OverlapPoint(mp))
			{
				newScene = 3;
			}
			else if (GameObject.FindGameObjectWithTag("CaminhoBlue").GetComponent<BoxCollider2D>().OverlapPoint(mp)) 
			{
				newScene = 4;
			}
        }
		print (newScene);
		print(Control);

		if (Control == 2) {

			if(newScene == 1){
				print ("foi");
				Application.LoadLevel(1);
			}
			if(newScene == 2){
				print ("foi");
				Application.LoadLevel(1);
			}
			if(newScene == 3){
				print ("foi");
				Application.LoadLevel(1);
			}
			if(newScene == 4){
				print ("foi");
				Application.LoadLevel(1);
			}

		}
	}
}
