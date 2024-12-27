using Unity.Netcode;
using UnityEngine;

namespace MyMultiplayer
{
    public class TW_MultiplayerManager : MonoBehaviour
    {
        public GameObject UI;

        private void Start()
        {
            UI.SetActive(true);
        }

        public void ButtonHost()
        {
            NetworkManager.Singleton.StartHost();
            UI.SetActive(false);
        }

        public void ButtonClient()
        {
            NetworkManager.Singleton.StartClient();
            UI.SetActive(false);
        }


    }
}
