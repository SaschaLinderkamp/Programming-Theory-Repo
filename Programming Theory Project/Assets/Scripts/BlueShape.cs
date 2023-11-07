using UnityEngine;

public class BlueShape : Shape
{
    void Start()
    {
        ShapeName = "Blue Shape";
        ShapeColor = Color.blue;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a blue shape.");
    }
}
