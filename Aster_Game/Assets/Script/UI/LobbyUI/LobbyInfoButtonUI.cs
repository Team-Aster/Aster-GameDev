using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Services.Lobbies.Models;
using AG.GameLogic.ObjectPooling;
using AG.Network.AGLobby;

namespace AG.UI.LobbyUI
{
    public class LobbyInfoButtonUI : PoolableObject
    {
        [SerializeField]
        private TextMeshProUGUI lobbyNameText;
        [SerializeField]
        private TextMeshProUGUI lobbyPlayersText;
        [SerializeField]
        private TextMeshProUGUI lobbyMaxPlayersText;
        private Lobby lobby;

        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(() => {
                LobbySingleton.instance.JoinLobbyByUI(lobby);
            });
        }

        public void UpdateLobbyButtonInfo(Lobby lobbyButton)
        {
            lobby = lobbyButton;

            lobbyNameText.text = lobby.Name;
            lobbyPlayersText.text = lobby.Players.Count.ToString();
            lobbyMaxPlayersText.text = lobby.MaxPlayers.ToString();
        }
    }
}