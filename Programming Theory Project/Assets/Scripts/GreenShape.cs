using UnityEngine;

public class GreenShape : Shape
{
    void Start()
    {
        ShapeName = "Green Shape";
        ShapeColor = Color.green;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a green shape.");
    }
}
