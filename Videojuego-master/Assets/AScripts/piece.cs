using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class piece : MonoBehaviour
{

 
    public int[] values;
	public float speed;
	float realRotation;

	int contador=0;


	public GameManager gm;


	// Use this for initialization
	void Start()
	{
		time.instanciar.iniciartime();

		gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

		
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.rotation.eulerAngles.z != realRotation)
		{
			transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, realRotation), speed);
		}

	}



	void OnMouseDown()
	{

	
		if (gameObject.tag == "Piece")
		{
			contador = contador + 1;

			Debug.Log(contador);
		}
		
		int difference = -gm.QuickSweep((int)transform.position.x, (int)transform.position.y);
		RotatePiece();

		difference += gm.QuickSweep((int)transform.position.x, (int)transform.position.y);

		gm.puzzle.curValue += difference;

		if (gm.puzzle.curValue == gm.puzzle.winValue)
			gm.Win();
	}

	public void RotatePiece()
	{
		realRotation += 90;
		if (realRotation == 360)
			realRotation = 0;
		RotateValues();
	}

	public void RotateValues()
	{
		int aux = values[0];
		for (int i = 0; i < values.Length - 1; i++)
		{
			values[i] = values[i + 1];
		}
		values[3] = aux;
	}
}