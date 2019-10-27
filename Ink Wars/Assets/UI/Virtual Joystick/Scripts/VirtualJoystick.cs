using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image backgroundImage;
    public Image BackgroundImage
    {
        get
        {
            if(!backgroundImage) backgroundImage = GetComponent<Image>();

            return backgroundImage;
        }
    }
    
    [SerializeField] private Image joystickImage;
    public Image JoystickImage
    {
        get
        {
            if(!joystickImage) joystickImage = transform.GetChild(0).GetComponent<Image>();

            return joystickImage;
        }
    }
    
    private Vector3 input;

    public Action<Vector2> OnAxisChanged = delegate { };
    public Action OnButtonAPressed = delegate { };

    public virtual void OnDrag(PointerEventData eventData) => MoveJoystick(eventData);

    public virtual void OnPointerDown(PointerEventData eventData) => MoveJoystick(eventData);

    public virtual void OnPointerUp(PointerEventData eventData) => ResetJoystick();

    private void MoveJoystick(PointerEventData eventData)
    {
        Vector2 position = Vector2.zero;

        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(backgroundImage.rectTransform, eventData.position, eventData.pressEventCamera, out position))
        {
            position = new Vector2(position.x/backgroundImage.rectTransform.sizeDelta.x, position.y/backgroundImage.rectTransform.sizeDelta.y);

            input = new Vector3(position.x * 2 + 1, 0, position.y * 2 - 1);

            input = (input.magnitude > 1) ? input.normalized : input;

            JoystickImage.rectTransform.anchoredPosition = new Vector3(input.x * (backgroundImage.rectTransform.sizeDelta.x / 2.5f), input.z * (backgroundImage.rectTransform.sizeDelta.y / 2.5f));

            OnAxisChanged(new Vector2(input.x, input.z));
        }
    }

    private void ResetJoystick()
    {
        input = Vector3.zero;

        joystickImage.rectTransform.anchoredPosition = Vector3.zero;

        OnAxisChanged(input);
    }
}
