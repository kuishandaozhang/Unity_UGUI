using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 登录面板
/// </summary>
public class LoginPanel : MonoBehaviour
{
    private InputField usernameInput;       //账号
    private InputField passwordInput;       //密码

    private Text usernameLimit;             //账号字符数限制 提示
    private Text passwordLimit;             //密码字符数限制 提示

    private Button loginBtn;                //登录按钮
    private Text title;                     //标题，用其提示登录成功与否


    private const int USERNAME_LIMIT = 10;              //账号字符数限制
    private const int PASSWORD_LIMIT = 15;              //密码字符数限制

    private const string ADMIN_USERNAME = "admin";      //管理员账号
    private const string ADMIN_PASSWORD = "admin";      //管理员密码


    void Start()
    {
        usernameInput = transform.Find("UsernameBar/UsernameInputField").GetComponent<InputField>();
        passwordInput = transform.Find("PasswordBar/PasswordInputField").GetComponent<InputField>();

        usernameLimit = transform.Find("UsernameBar/CharacterCount").GetComponent<Text>();
        passwordLimit = transform.Find("PasswordBar/CharacterCount").GetComponent<Text>();

        loginBtn = transform.Find("LoginBtn").GetComponent<Button>();
        title = transform.Find("Title").GetComponent<Text>();

        //监听 输入变化
        usernameInput.onValueChanged.AddListener(OnUsernameChanged);
        passwordInput.onValueChanged.AddListener(OnPasswordChanged);

        //监听 编辑完毕
        usernameInput.onEndEdit.AddListener(CheckUsername);
        passwordInput.onEndEdit.AddListener(CheckPassword);

        loginBtn.onClick.AddListener(OnLoginBtnClick);
    }


    /// <summary>
    /// 用户名发生变化
    /// </summary>
    private void OnUsernameChanged(string username)
    {
        usernameLimit.text = username.Length + "/" + USERNAME_LIMIT;
    }

    /// <summary>
    /// 密码发生变化
    /// </summary>
    private void OnPasswordChanged(string password)
    {
        passwordLimit.text = password.Length + "/" + PASSWORD_LIMIT;
    }

    /// <summary>
    /// 检查用户名是否正确
    /// </summary>
    private void CheckUsername(string username)
    {
        if (username != ADMIN_USERNAME)     //当前不为管理员账号
        {
            usernameLimit.text = "<color=#FF0000FF>账号错误!</color>";
        }
    }

    /// <summary>
    /// 检查密码是否正确
    /// </summary>
    private void CheckPassword(string password)
    {
        if (password == ADMIN_PASSWORD) return;     //密码正确，直接返回

        passwordLimit.text = "<color=#FF0000FF>密码错误!</color>";
    }


    /// <summary>
    /// 尝试登录
    /// </summary>
    private void OnLoginBtnClick()
    {
        if (usernameInput.text == ADMIN_USERNAME && passwordInput.text == ADMIN_PASSWORD)   //账号与密码皆正确
        {
            title.text = "<size=26><color=green>登录成功！</color></size>";
            return;
        }

        //账号密码一方有错，或二者皆错
        title.text = "<color=red><size=26>登录失败！</size></color>";
    }
}
