using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;
using System;
public class TemperatureSensor : MonoBehaviour
{
    public string brokerIpAddress = "192.168.0.113";
	public int brokerPort = 5001;
	public string temperatureTopic = "casa/sala/temperatura";
    private MqttClient client;
    public float reportRate = 5;
    public float temperatureValue = 23.3f;
    private float reportTimer;
    // Start is called before the first frame update
    void Start()
    {
        // create client instance 
		client = new MqttClient(IPAddress.Parse(brokerIpAddress), brokerPort, false, null); 		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
    }

    // Update is called once per frame
    void Update()
    {
        if ((reportTimer += Time.deltaTime) >= reportRate)
        {			
            Debug.Log("sending...");
			client.Publish("casa/sala/luz", System.Text.Encoding.UTF8.GetBytes("lightOn"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
			Debug.Log("sent");
            reportTimer = 0f;
        }
    }
}
