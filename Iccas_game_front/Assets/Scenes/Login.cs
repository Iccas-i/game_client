using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class LoginManager : MonoBehaviour
{
    public TMP_InputField idInput;
    public TMP_InputField passwordInput;
    public Button loginButton;
    public Button SignUpButton;
    public TMP_Text statusText;
    

    private string loginURL = "http://localhost:3000/login"; //http 웹 주소

    private void Start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClick);    // 로그인 버튼
        SignUpButton.onClick.AddListener(OnSignUpButtonClick); // 회원가입 버튼 이벤트 리스너 추가
    }
    

    private void OnLoginButtonClick()
    {
        StartCoroutine(Login());
    }

    private void OnSignUpButtonClick()
    {
        SceneManager.LoadScene("Sign_Up"); // 회원가입 버튼 클릭 시 회원가입 씬으로 전환
    }

    private IEnumerator Login()
    {
        statusText.text = "Logging in...";

        WWWForm form = new WWWForm();
        form.AddField("User_ID", idInput.text);
        form.AddField("User_PW", passwordInput.text);
        //
        UnityWebRequest request = UnityWebRequest.Post(loginURL, form);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            statusText.text = "Error: " + request.error;
        }
        else
        {
            if (request.responseCode == 200)        // 200 - 서버와 연결 성공 여부
            {  
                if(request.downloadHandler.text == "T"){        // 로그인 성공시
                    statusText.text = "로그인 성공! " + idInput.text +"님 안녕하세요!"; // 안내 문구 출력
                    yield return new WaitForSeconds(1); // 로그인 성공 후 1초 대기
                    SceneManager.LoadScene("Home"); // 로그인 성공 후 MainScene으로 전환
                }
                else if(request.downloadHandler.text == "F"){    // 로그인 실패시
                    statusText.text = "아이디 또는 비밀번호가 틀렸습니다";  // 안내 문구 출력
                }
        
            }
            
            else
            {
                statusText.text = "Error: Invalid credentials.";
            }
        }
    }
}
