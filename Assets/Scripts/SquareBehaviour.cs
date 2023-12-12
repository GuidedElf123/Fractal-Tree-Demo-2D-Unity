using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBehaviour : MonoBehaviour
{
    public Transform[] SpawnPointsCorners;
    public Transform[] PrefabSquares;

    void Start()
    {
       
       GameManager gManager = GameObject.Find("GameManagerObject").GetComponent<GameManager>();

        if (gManager.Count < gManager.NWaves)
        {           
            GameObject topLeftSquareClone = Instantiate(PrefabSquares[0].gameObject);
            GameObject topRightSquareClone = Instantiate(PrefabSquares[1].gameObject);

            gManager.Squares.Add(topLeftSquareClone);
            gManager.Squares.Add(topRightSquareClone);

            topLeftSquareClone.transform.parent = transform;
            topRightSquareClone.transform.parent = transform;


            topLeftSquareClone.transform.localScale = new Vector2(this.transform.localScale.x * gManager.scaleRatio, this.transform.localScale.y * gManager.scaleRatio);
            topRightSquareClone.transform.localScale = new Vector2(this.transform.localScale.x * gManager.scaleRatio, this.transform.localScale.y * gManager.scaleRatio);


            topLeftSquareClone.transform.position = SpawnPointsCorners[0].position; //top left...
            topRightSquareClone.transform.position = SpawnPointsCorners[1].position; //top right...    
        }
        gManager.Count++;

    }
}
