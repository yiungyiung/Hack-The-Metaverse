using UnityEngine;

public class CandlestickChart : MonoBehaviour
{
    public GameObject linePrefab; // Assign your LineRenderer prefab in the Inspector

    private float[] openPrices = new float[] { 100.0f, 105.0f, 110.0f, 115.0f, 120.0f, 125.0f, 132.0f, 135.0f, 140.0f, 145.0f };
    private float[] closePrices = new float[] { 120.0f, 110.0f, 115.0f, 120.0f, 125.0f, 132.0f, 135.0f, 140.0f, 145.0f, 142.0f };

    void Start()
    {
        GenerateGraph();
    }

    void GenerateGraph()
    {
        float previousEnd = 0;
        float xOffset = 1; // Set this to the desired distance between LineRenderers

        int x=0;
        for (int i = 1; i < openPrices.Length; i++)
        {
            GameObject lineObject = Instantiate(linePrefab);
            LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();

            // Calculate the height of the LineRenderer based on the difference between the opening and closing prices
            float height = closePrices[i] - openPrices[i];

            // Set the position of the LineRenderer
            
            Vector3 startPoint = new Vector3((i -1) * xOffset , previousEnd , x );
            Vector3 endPoint = new Vector3((i -1) * xOffset , previousEnd + height , x+1);
            Vector3 StartPoint = new Vector3((i -1) * xOffset , previousEnd , x );
            Vector3 EndPoint = new Vector3((i -1) * xOffset , previousEnd + height , x-1);
            if(height<0)
            {
            lineRenderer.SetPosition(0,EndPoint);
            lineRenderer.SetPosition(1,StartPoint);
            lineObject.GetComponent<Renderer>().material.color=Color.red;
            x=x-1;
            }
            else{
            lineRenderer.SetPosition(0,startPoint);
            lineRenderer.SetPosition(1,endPoint);
            x=x+1;
            }

            // Update the end position for the next LineRenderer
            previousEnd += height;
        }
    }
}
