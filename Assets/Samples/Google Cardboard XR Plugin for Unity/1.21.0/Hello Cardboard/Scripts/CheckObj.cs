using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObj : MonoBehaviour
{
  public CandlestickChart ch;
   public enum button{
        Buy,
        Sell,
        Plus,
        Minus,
        Book,
        Cheque,
        Cut,
        Sticky,
        whitebaord,
    }
    public bool changelable;
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
        if(changelable)
        myRenderer.material.color = inatctiveColor;
    }

    // Update is called once per frame
    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject. /// </summary>
    public void OnPointerEnter()
    {
        GazeAt(true);
        if (selectedButton == button.Sticky)
        {
            gameObject.transform.localScale=new Vector3(2.5f,2.5f, 0.1f);
        }
        if (selectedButton == button.whitebaord)
        {
            gameObject.transform.localScale=new Vector3(5f,5f, 0.1f);
        }
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject. /// </summary>
    public void OnPointerExit()
    {
        GazeAt(false);
        if (selectedButton == button.Sticky)
        {
            gameObject.transform.localScale=new Vector3(0.6f,0.6f,0.01f);
        }
        if (selectedButton == button.whitebaord)
        {
            gameObject.transform.localScale=new Vector3(2f,2f,0.01f);
        }
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
        ch.buy();
        // Add code for the "Buy" button functionality here.
        Debug.Log("Buy button clicked.");
    }

     void SellFunction()
    {   
        ch.sell();
        // Add code for the "Sell" button functionality here.
        Debug.Log("Sell button clicked.");
    }

     void PlusFunction()
    {
        // Add code for the "Plus" button functionality here.
        ch.upshares();
        Debug.Log("Plus button clicked.");
    }

     void MinusFunction()
    {   
        ch.downshares();
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
            if(changelable)
            myRenderer.material.color = gazedAtColor;
        }
        else
            if(changelable)
            myRenderer.material.color = inatctiveColor;
    }
}
