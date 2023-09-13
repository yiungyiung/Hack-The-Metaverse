using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObj : MonoBehaviour
{
    enum button{
        buy,
        sell,
        plus,
        minus
    }

    [SerializeField]
    private Color inatctiveColor;

    [SerializeField]
    private Color gazedAtColor;

    private MeshRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inatctiveColor;
    }

    // Update is called once per frame
    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject. /// </summary>
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject. /// </summary>
    public void OnPointerExit()
    {
        GazeAt(false);
    }

    public void OnPointerClick()
    {
        Debug.LogError("clicked");
        Destroy(gameObject);
    }
    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            myRenderer.material.color = gazedAtColor;
        }
        else
            myRenderer.material.color = inatctiveColor;
    }
}
