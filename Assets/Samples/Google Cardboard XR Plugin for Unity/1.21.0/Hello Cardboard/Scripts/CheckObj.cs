using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObj : MonoBehaviour
{
   public enum button{
        Buy,
        Sell,
        Plus,
        Minus,
        Book,
        Cheque,
        Cut,
    }
    public GameObject Book;
    [SerializeField]
    private Color inatctiveColor;

    [SerializeField]
    private Color gazedAtColor;

    private MeshRenderer myRenderer;
    public button selectedButton;
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
        switch (selectedButton)
        {
            case button.Buy:
                BuyFunction();
                break;
            case button.Sell:
                SellFunction();
                break;
            case button.Plus:
                PlusFunction();
                break;
            case button.Minus:
                MinusFunction();
                break;
            case button.Book:
                BookFunction();
                break;
            case button.Cheque:
                ChequeFunction();
                break;
            case button.Cut:
                CutBookFunction();
                break;
    }
    }

         void BuyFunction()
    {
        // Add code for the "Buy" button functionality here.
        Debug.Log("Buy button clicked.");
    }

     void SellFunction()
    {
        // Add code for the "Sell" button functionality here.
        Debug.Log("Sell button clicked.");
    }

     void PlusFunction()
    {
        // Add code for the "Plus" button functionality here.
        Debug.Log("Plus button clicked.");
    }

     void MinusFunction()
    {
        // Add code for the "Minus" button functionality here.
        Debug.Log("Minus button clicked.");
    }

     void BookFunction()
    {
        Book.SetActive(true);
        gameObject.SetActive(false);
        Debug.Log("Book button clicked.");
    }

     void ChequeFunction()
    {
        // Add code for the "Cheque" button functionality here.
        Debug.Log("Cheque button clicked.");
    }

     void CutBookFunction()
    {       
            Book.SetActive(true);
            gameObject.SetActive(false);
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
