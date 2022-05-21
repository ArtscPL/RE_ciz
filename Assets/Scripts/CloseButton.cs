using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CloseButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject target;
    public int scenesLoad;
    public void OnPointerClick(PointerEventData eventData)
    {
        target.gameObject.SetActive(!target.gameObject.activeSelf);
        scenesLoad = MoveData.Scene_index;
        Debug.Log("Move to Scene "+scenesLoad);
        SceneManager.LoadScene(scenesLoad);
    }
}