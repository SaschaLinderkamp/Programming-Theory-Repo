using UnityEngine;

// INHERITANCE
public class Shape : MonoBehaviour
{
    private string shapeName;
    private Color shapeColor;

    public string ShapeName
    {
        // ENCAPSULATION
        get { return shapeName; }
        set { shapeName = value; }
    }

    public Color ShapeColor
    {
        // ENCAPSULATION
        get { return shapeColor; }
        set { shapeColor = value; }
    }

    public virtual void DisplayText()
    {
        // POLYMORPHISM
        Debug.Log("This is a basic shape.");
    }

    // ABSTRACTION
    private void OnMouseDown()
    {
        DisplayText();
    }
}