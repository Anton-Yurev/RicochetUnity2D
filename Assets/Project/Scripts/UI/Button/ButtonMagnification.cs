using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMagnification : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image _image;
    private Transform _baseTransform;
    private Color _baseColor;
    private Color _newColor=Color.red;
    private float _magnificationSize = 1.2f;
    void Start()
    {
        _image = GetComponent<Image>();
        _baseTransform = GetComponent<Transform>();

        _baseColor = _image.color;  // save base color
        _baseTransform.localScale = gameObject.transform.localScale;    // save base scale
    }

    public void OnPointerEnter(PointerEventData eventData)  //called when the cursor is hovered over
    {
        _image.color = _newColor; //set new color
        gameObject.transform.localScale = Vector2.one * _magnificationSize;  //set new scale
    }

    public void OnPointerExit(PointerEventData eventData) //called when the cursor is held down
    {
        _image.color = _baseColor;  //return base color
        gameObject.transform.localScale = Vector2.one;  //return base scale
    }
}
