using UnityEngine;
using System.Collections;
using System;

namespace UnityClusterPackage {
    
    public class InstantiateNode : MonoBehaviour {
        
        public Transform VRWorld;
        public Transform shellCameras;
        public Transform shellScreens;

        
        void Awake() {
            Network.sendRate = 100;
        }
        
        void Start () {
            
            if ( NodeInformation.type.Equals("master") )
            {
                Network.proxyIP = NodeInformation.serverIp;
                bool useNat = Network.HavePublicAddress();
                Network.InitializeServer( NodeInformation.nodes, NodeInformation.serverPort, useNat );

                shellScreens.GetChild(0).gameObject.SetActive(true);
                shellScreens.GetChild(1).gameObject.SetActive(true);
                shellCameras.GetChild(0).gameObject.SetActive(true);
                shellCameras.GetChild(1).gameObject.SetActive(true);
                IntPtr windowPtr = CC_WINDOWPLACER.FindWindow(null, "ClusterTest");
                CC_WINDOWPLACER.SetWindowText(windowPtr, "Master");
                CC_WINDOWPLACER.SetPosition(0, 0, "Master");

            }

            else if ( NodeInformation.type.Equals("slave1") )
            {
                Network.Connect( NodeInformation.serverIp, NodeInformation.serverPort );

                shellScreens.GetChild(2).gameObject.SetActive(true);
                shellScreens.GetChild(3).gameObject.SetActive(true);
                shellCameras.GetChild(2).gameObject.SetActive(true);
                shellCameras.GetChild(3).gameObject.SetActive(true);
                IntPtr windowPtr = CC_WINDOWPLACER.FindWindow(null, "ClusterTest");
                CC_WINDOWPLACER.SetWindowText(windowPtr, "Slave1");
                CC_WINDOWPLACER.SetPosition(0 + (1 * Screen.width), 0, "Slave1");

            }

            else if (NodeInformation.type.Equals("slave2"))
            {
                Network.Connect(NodeInformation.serverIp, NodeInformation.serverPort);

                shellScreens.GetChild(4).gameObject.SetActive(true);
                shellScreens.GetChild(5).gameObject.SetActive(true);
                shellCameras.GetChild(4).gameObject.SetActive(true);
                shellCameras.GetChild(5).gameObject.SetActive(true);
                IntPtr windowPtr = CC_WINDOWPLACER.FindWindow(null, "ClusterTest");
                CC_WINDOWPLACER.SetWindowText(windowPtr, "Slave2");
                CC_WINDOWPLACER.SetPosition(0 + (2 * Screen.width), 0, "Slave2");
            }

        }
        
        void OnServerInitialized()
        {
            Debug.Log( "Server initialized and ready." );
        }
        
        void OnPlayerConnected(NetworkPlayer player) {
            Debug.Log( "Node connected " + player.ipAddress + ":" + player.port );
        }
        
        void OnPlayerDisconnected( NetworkPlayer node ) {
            Debug.Log( "Clean up after player " + node );
            Network.RemoveRPCs(node);
            Network.DestroyPlayerObjects(node);
        }
        
        void OnConnectedToServer()
        {
            Debug.Log( "Connected to server." );
        }
        
        void OnFailedToConnect(NetworkConnectionError error)
        {
            Debug.Log( "Could not connect to server: " + error );
        }
        
        void OnDestroy() {
            
            if ( NodeInformation.type.Equals("master") )
            {
                Network.Disconnect();
            }
            else if ( NodeInformation.type.Equals("slave") )
            {
                Network.CloseConnection( Network.player, true );                
            }
        }
        
    }
}