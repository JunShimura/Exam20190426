using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExecButtonManager : MonoBehaviour {

    public Dropdown dropdown;
    public Text answerText;
    public GameObject numValue1;
    public GameObject numValue2;
    NumValueManager numValueManager1;
    NumValueManager numValueManager2;
    float n1;
    float n2;
         
    // Use this for initialization
	void Start () {

        numValueManager1 = numValue1.GetComponent<NumValueManager>();
        numValueManager2 = numValue2.GetComponent<NumValueManager>();

    }

    public void Exec()
    {
        //処理
        n1 = numValueManager1.Value;
        n2 = numValueManager2.Value;
        int selected = dropdown.value;
        switch(selected)
        {
            case 0:
                answerText.text = Ex0();
                break;
            case 1:
                answerText.text = Ex1();
                break;
            case 2:
                answerText.text = Ex2();
                break;
            case 3:
                answerText.text = Ex3();
                break;
            case 4:
                answerText.text = Ex4();
                break;
            case 5:
                answerText.text = Ex5();
                break;
            case 6:
                answerText.text = Ex6();
                break;
            case 7:
                answerText.text = Ex7();
                break;
            case 8:
                answerText.text = Ex8();
                break;
            case 9:
                answerText.text = Ex9();
                break;
            case 10:
                answerText.text = Ex10();
                break;
            default:
                break;
        }
    }
    string Ex0()
    {   
        //問題0
        string answer="";   //こたえのメッセージ
        //ここで答えを出してanswerへ代入する
        float result = n1 + n2;   //計算結果   

        answer = result.ToString(); //計算結果をanswerに入れて返す
        //answer = n1 + "+" + n2 + "=" + result.ToString(); 
        return answer;
    }
    string Ex1()
    {
        //問題1
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex1 まだやってません";
        return answer;
    }
    string Ex2()
    {
        //問題2
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex2 まだやってません";
        return answer;
    }
    string Ex3()
    {
        //問題3
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex3 まだやってません";
        return answer;
    }
    string Ex4()
    {
        //問題4
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex4 まだやってません";
        return answer;
    }
    string Ex5()
    {
        //問題5
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex5 まだやってません";
        return answer;
    }
    string Ex6()
    {
        //問題6
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex6 まだやってません";
        return answer;
    }
    string Ex7()
    {
        //問題7
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex7 まだやってません";
        return answer;
    }
    string Ex8()
    {
        //問題8
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex8 まだやってません";
        return answer;
    }
    string Ex9()
    {
        //問題9
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex9 まだやってません";
        return answer;
    }
    string Ex10()
    {
        //問題10
        string answer = "";
        //ここで答えを出してanswerへ代入する
        answer = "Ex10 まだやってません";
        return answer;
    }

}
