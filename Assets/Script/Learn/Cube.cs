using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        GameObject obj = GameObject.Find("Sphere");
        if (!obj)
        {
            Debug.Log("��ü�� ã���� �����ϴ�");
        }
        //Debug.Log(obj.transform.position.x);
        Debug.Log(obj.GetComponent<Sphere>().WhoAmI("JIHUN"));
        

        GameObject obj2 = GameObject.FindWithTag("Sphere");
        if (!obj2)
        {
            Debug.Log("��ü�� ã���� �����ϴ�");
        }
       // Debug.Log(obj.transform.position.x);

        
    }
}
/*GetComponent<>() �Լ��� ����Ͽ� �ش� ������Ʈ�� ����� �Լ��� ������ ��,
public �� �ƴ� private�� ����� �Լ��� �����ϸ�, � ����� �������� Ȯ��
�ϼ���*/

//: Assets\Script\Learn\Cube.cs(15, 36): error CS0122: 'Sphere.WhoAmI(string)' is inaccessible due to its protection level ���� 

/*GetComponent<>() �Լ��� ����Ͽ� �ش� ������Ʈ�� ����� �Լ��� �����ϴ� ��
���� SendMessage() �Լ��� ����Ͽ� �ش� ������Ʈ�� ����� �Լ��� �����ϴ�
����� ���̸� Ȯ���ϼ���.*/

//�ܺν�ũ��Ʈ �Լ� ȣ���� 1: GetComponent , 2: SendMessage
//�Ű������� 2�� �̻��̸� SendMessage�� ������� ����
