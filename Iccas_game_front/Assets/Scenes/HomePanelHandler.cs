using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Networking;

public class HomePanelHandler : MonoBehaviour
{
    public TMP_InputField waterAmountInput;
    public TMP_InputField caloriesInput;
    public TMP_InputField stepsInput;
    public TMP_InputField fastingInput;
    public TMP_InputField sleepInput;
    public TextMeshProUGUI responseText;
    public GameObject popupPanel;
    public GameObject previousPanel;

    private string serverURL = "http://192.168.0.95:3000/post/health";

    public void OnSaveButtonClick()
    {
        if (IsAllDataFilled())
        {
            StartCoroutine(SendDataToServer());
        }
        else
        {
            responseText.text = "모든 데이터를 입력해 주세요.";
            responseText.gameObject.SetActive(true);
        }
    }

    IEnumerator SendDataToServer()
    {
        // 데이터 생성
        WWWForm form = new WWWForm();
        form.AddField("User_ID","1234");
        form.AddField("Water_Intake", waterAmountInput.text);
        form.AddField("Calorie", caloriesInput.text);
        form.AddField("Walk", stepsInput.text);
        form.AddField("Hungry_Time", fastingInput.text);
        form.AddField("Sleep_Duration", sleepInput.text);

        // 서버로 요청 보내기
        using (UnityWebRequest www = UnityWebRequest.Post(serverURL, form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success) // 성공시 정보 저장
            {   
                responseText.text = www.downloadHandler.text;
                yield return new WaitForSeconds(2); // 로그인 성공 후 1초 대기
                responseText.gameObject.SetActive(true);
                GoToPreviousPanel();
            }
            else // 실패시
            {
                responseText.text = www.downloadHandler.text;
                yield return new WaitForSeconds(2); // 로그인 성공 후 1초 대기
                responseText.gameObject.SetActive(true);
            }
        }
    }

    bool IsAllDataFilled()
    {
        return !(string.IsNullOrEmpty(waterAmountInput.text) || 
                 string.IsNullOrEmpty(caloriesInput.text) || 
                 string.IsNullOrEmpty(stepsInput.text) || 
                 string.IsNullOrEmpty(fastingInput.text) || 
                 string.IsNullOrEmpty(sleepInput.text));
    }

    void GoToPreviousPanel()
    {
        popupPanel.SetActive(false);        // 현재 패널 은 끄고
        previousPanel.SetActive(true);      // 이전 패널은 키고
    }
}
