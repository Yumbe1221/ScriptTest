using UnityEngine;
using System.Collections;

public class Boss
{
    private int mp = 53;  // mp

    // 魔法攻撃用の関数
    public void Magic(int damage)
    {
        if (mp < damage)
        {
            Debug.Log("MPが足りないため魔法が使えない。" );
        }
        else
        {
            // 残りmpを減らす
            this.mp -= damage;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }

    }



}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        


        // 10回処理を繰り返す
        for (int i = 0; i < 11; i++)
        {
            // 魔法攻撃用の関数を呼び出す
            lastboss.Magic(10);
        }
    }
      
   
    // Update is called once per frame
    void Update()
    {

    }
}