using UnityEngine;

public class RedShape : Shape
{
    void Start()
    {
        ShapeName = "Red Shape";
        ShapeColor = Color.red;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a red shape.");
    }
}