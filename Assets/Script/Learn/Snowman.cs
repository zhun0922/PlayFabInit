using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    private void Start()
    {
        GameObject obj = GameObject.Find("Snowman");

        //ù��° �ڽ� ������Ʈ ã��
        Transform getChild = obj.transform.GetChild(0);
        //Debug.Log(getChild.name);

        //�ڽ��� ������(index = 0) �ڽĿ�����Ʈ ��� ã�� (1~ allChildren.Length-1)
        Transform[] allChildren = obj.GetComponentsInChildren<Transform>();
        if (allChildren == null) return;

        //INDEX 1���� FOR�������� �ڱ� �ڽ� ����
        for (int i = 1; i < allChildren.Length; i++)
        {
            Debug.Log(allChildren[i].name);
        }

        //name�� �ڽ��϶� continue �ڱ� �ڽ� ����
        foreach (Transform t in allChildren)
        {
            if (t.name == "Snowman")
            {
                continue;
            }
            Debug.Log(t.name);
        }
    }
}
