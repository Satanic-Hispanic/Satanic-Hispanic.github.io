using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour {

	public float gridSize = 2f;
	Vector3 startPos;
	Vector3 enemy;
    public Transform[] loseSpot;
    public Transform winSpot;
    
    // Vector3 textStartPos;
    public TextMesh displayText;
	public TextMesh scoreTex;
    public int maxGrid = 8;
    public int minGrid = 0;
    public int grid = 2;
    public int randoX;
    public int randoZ;
	public int score = 0;
    public GameObject background;

	//



    // Use this for initialization
    void Start () {
		//displayText.text = ;
		//displays the score at the beginning
		scoreTex.text = score.ToString ();
		startPos = transform.position;

        // textStartPos = text.position;



        //int randoX = (int)(Random.Range(minGrid, maxGrid / grid));
        //Debug.Log(randoX);
        //randoX *= grid;
        //int randoZ = (int)(Random.Range(minGrid, maxGrid / grid));
        //Debug.Log(randoZ);
        //randoZ *= grid;
    }

    // Update is called once per frame
    void Update()
    {
		//Updates my score on the game screen
		scoreTex.text = score.ToString ();
        if (Input.GetKeyDown(KeyCode.W) && transform.position.z < 7f)
        {
            Debug.Log("player pressed the w key");
            transform.position += transform.forward * gridSize;
			displayText.transform.position =  new Vector3(100f,100f,100f);
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -7f)
        {
            Debug.Log("player pressed the a key");
            transform.position += -transform.right * gridSize;
			displayText.transform.position =  new Vector3(100f,100f,100f);
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.z > -7f)
        {
            Debug.Log("player pressed the s key");
            transform.position += -transform.forward * gridSize;
			displayText.transform.position =  new Vector3(100f,100f,100f);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 7f)
        {
            Debug.Log("player pressed the d key");
            transform.position += transform.right * gridSize;
			displayText.transform.position =  new Vector3(100f,100f,100f);
        }



      

        for (int i = 0; i < loseSpot.Length; i++)
        {
            if (transform.position == loseSpot[i].position)
            {
                transform.position = startPos;
				score--;
				//Display's wasted when hitting enemy/wall
                displayText.text = "Wasted!";
				displayText.transform.position =  new Vector3(8.29f,-1.54f,-9.26f);
            }

        }

        for (int i = 0; i < loseSpot.Length; i++)
		{
            //while (randoX == winSpot.transform.position.x && randoZ == winSpot.transform.position.z)
            //{
            //    randoX = (int)(Random.Range(minGrid, maxGrid / gridSize));
            //    randoX *= grid;
            //    randoZ = (int)(Random.Range(minGrid, maxGrid / gridSize));
            //    randoZ *= grid;
            //}

            if (transform.position == winSpot.position)
            {
				//makes score go up but does not show on score display 
				score++;
                //  text.position = textStartPos;
                displayText.text = "Winner";
                background.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                transform.position = startPos;
				displayText.transform.position =  new Vector3(8.29f,-1.54f,-9.26f);
            }

			//reset when pressing the space key
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position = startPos;

            }

        }
    }



    
    }
