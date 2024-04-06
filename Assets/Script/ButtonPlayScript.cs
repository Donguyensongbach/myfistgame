using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonPlayScript : MonoBehaviour,IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventDatav)
    {
        SceneManager.LoadScene("LV1");
    }
}