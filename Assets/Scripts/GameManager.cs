using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Count, NWaves;
    public float scaleRatio, rotation, Scale;
    public List<GameObject> Squares;
    public GameObject Root;
    public Slider RotSlider, ScaleSlider;
    void Start()
    {

        GameObject rootClone = Instantiate(Root);
    }

    void Update()
    {

        foreach (GameObject Square in Squares)
        {
            Square.transform.localScale = new Vector2( ScaleSlider.value, ScaleSlider.value);//anti clockwise

            if (Square.tag == "Left")
            {
                Square.transform.localRotation = Quaternion.Euler(0f, 0f, -RotSlider.value);//anti clockwise

                
            }
            else if(Square.tag == "Right") 
            {
                Square.transform.localRotation = Quaternion.Euler(0f, 0f, RotSlider.value);//anti clockwise

            }
        }
    }
}
