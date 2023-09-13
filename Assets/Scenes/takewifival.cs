using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

public class takewifival : MonoBehaviour
{
    private WebSocket ws;
    public string butpress;
    public CardboardReticlePointer cr;
    void Start()
    {
        // Replace with the IP address of your NodeMCU
        string serverAddress = "ws://192.168.4.1:8080";

        ws = new WebSocket(serverAddress);
        ws.OnMessage += OnMessage;
        ws.Connect();
    }

    private void OnMessage(object sender, MessageEventArgs e)
    {
        // Handle received messages here
        Debug.Log("Received message: " + e.Data);
    }
    private void OnDestroy()
    {
        if (ws != null && ws.IsAlive)
        {
            ws.Close();
        }
    }
}