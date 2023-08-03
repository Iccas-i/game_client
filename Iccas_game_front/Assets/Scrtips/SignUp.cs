using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SignUpManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField idInput;
    public TMP_InputField passwordInput;
    public TMP_InputField phoneInput;
    public TMP_InputField emailInput;
    public TMP_InputField ageInput;
    public TMP_InputField genderInput;
    public TMP_InputField heightInput;
    public TMP_InputField weightInput;
    public TMP_InputField nicknameInput;
    public Button signUpButton;
    public Button backButton;
    public TMP_Text statusText;
    

    private string signUpURL = "http://3.224.156.19:3000/reg";

    private void Start()
    {
        signUpButton.onClick.AddListener(OnSignUpButtonClick);
        backButton.onClick.AddListener(OnBackButtonClick);
    }

    private void OnSignUpButtonClick()
    {
        StartCoroutine(SignUp());
    }

    private void OnBackButtonClick()
    {
        SceneManager.LoadScene("Sign_In");
    }

    private IEnumerator SignUp()
    {
        statusText.text = "Signing up...";

        WWWForm form = new WWWForm();
        form.AddField("User_Name", nameInput.text);
        form.AddField("User_ID", idInput.text);
        form.AddField("User_PW", passwordInput.text);
        form.AddField("User_Phone", phoneInput.text);
        form.AddField("User_Email", emailInput.text);
        form.AddField("User_Age", ageInput.text);
        form.AddField("User_sex", genderInput.text);
       
        if(heightInput.text == "")
        {
            heightInput.text = "0.0";
        }
        if(weightInput.text == ""){
            weightInput.text = "0.0";
        } 
        form.AddField("User_Height", heightInput.text);
        form.AddField("User_Weight", weightInput.text);
        form.AddField("User_Nickname", nicknameInput.text);

        UnityWebRequest request = UnityWebRequest.Post(signUpURL, form);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            statusText.text = "Error: " + request.error;
        }
        else
        {
            if (request.responseCode == 200)
            {
                if(request.downloadHandler.text == "T"){
                    statusText.text = "회원가입 성공!";
                    yield return new WaitForSeconds(1); // 로그인 성공 후 1초 대기
                    SceneManager.LoadScene("Sign_In"); // 로그인 성공 후 MainScene으로 전환
                }
                else if(request.downloadHandler.text == "F"){
                    statusText.text = "다시 작성해주세요!";
                    yield return new WaitForSeconds(1); // 로그인 성공 후 1초 대기
                    statusText.text = "";
                }
                //yield return new WaitForSeconds(1); // 로그인 성공 후 1초 대기
                //SceneManager.LoadScene("Home"); // 로그인 성공 후 MainScene으로 전환
            }
            else
            {
                statusText.text = "Error: Could not sign up.";
            }
        }
    }
}
