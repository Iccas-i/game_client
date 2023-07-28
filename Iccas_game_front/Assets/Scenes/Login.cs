using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class LoginManager : MonoBehaviour
{
    public TMP_InputField idInput;
    public TMP_InputField passwordInput;
    public Button loginButton;
    public TMP_Text statusText;
    

    private string loginURL = "http://localhost:3000/login"; //http 웹 주소

    private void Start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnLoginButtonClick()
    {
        StartCoroutine(Login());
    }

    private IEnumerator Login()
    {
        statusText.text = "Logging in...";

        WWWForm form = new WWWForm();
        form.AddField("User_ID", idInput.text);
        form.AddField("User_PW", passwordInput.text);

        UnityWebRequest request = UnityWebRequest.Post(loginURL, form);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            statusText.text = "Error: " + request.error;
        }
        else
        {
            if (request.responseCode == 200)
            {  
                statusText.text = "Successfully logged in as " + idInput.text + request.downloadHandler.text;
            }
            else
            {
                statusText.text = "Error: Invalid credentials.";
            }
        }
    }
}
