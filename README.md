# Uni Message Box

![2020-05-01_214401](https://user-images.githubusercontent.com/6134875/80806220-0d068180-8bf5-11ea-8448-291a5efead23.png)

Unity エディタで Windows のメッセージボックスを表示できるパッケージ

## 使用例

```cs
using UniMessageBox;
using UnityEditor;
using UnityEngine;

public class Example
{
    [MenuItem( "Tools/Show1" )]
    private static void Show1()
    {
        Debug.Log( MessageBox.Show( "テキスト" ) );
    }

    [MenuItem( "Tools/Show2" )]
    private static void Show2()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション" ) );
    }

    [MenuItem( "Tools/Show3" )]
    private static void Show3()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.OK ) );
    }

    [MenuItem( "Tools/Show4" )]
    private static void Show4()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.OKCancel ) );
    }

    [MenuItem( "Tools/Show5" )]
    private static void Show5()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.AbortRetryIgnore ) );
    }

    [MenuItem( "Tools/Show6" )]
    private static void Show6()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.YesNoCancel ) );
    }

    [MenuItem( "Tools/Show7" )]
    private static void Show7()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.YesNo ) );
    }

    [MenuItem( "Tools/Show8" )]
    private static void Show8()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.RetryCancel ) );
    }

    [MenuItem( "Tools/Show9" )]
    private static void Show9()
    {
        Debug.Log( MessageBox.Show( "テキスト", "キャプション", MessageBoxButtons.OK, MessageBoxIcon.Information ) );
    }
}
```