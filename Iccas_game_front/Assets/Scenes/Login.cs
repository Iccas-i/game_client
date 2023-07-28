using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField idInput;
    public InputField passwordInput;
    public Button loginButton;
    public Text statusText;

    private string loginURL = "http://localhost:3000/login";

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
        form.AddField("id", idInput.text);
        form.AddField("password", passwordInput.text);

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
                statusText.text = "Successfully logged in as " + idInput.text;
            }
            else
            {
                statusText.text = "Error: Invalid credentials.";
            }
        }
    }
}
