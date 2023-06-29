using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoViewerController : MonoBehaviour
{
    public Image photoViewer;
    void Start()
    {
        photoViewer.gameObject.SetActive(false);
    }

    public void TogglePhotoViewer()
    {
        photoViewer.gameObject.SetActive(!photoViewer.gameObject.activeSelf);
    }
}
