using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteraction : MonoBehaviour
{
    public Material mat;
    private float _bits;
    [Header("������ bit count")]
    public float startBitsCount = 4;
    [Header("������ bit count")]
    public float bitsCount = 10;
    [Header("������ �̹��� ����Ʈ")]
    public List<Texture> textureList = new List<Texture>();
    private Texture _selectedTexture;
    private int textureCount = 0;

    private void Start()
    {
        mat.SetFloat("_Bits", startBitsCount);
        _selectedTexture = textureList[0];
        mat.SetTexture("_MainTex", _selectedTexture);
    }

    private void Update()
    {
        

        // ���콺 ���� Ŭ�� �� ��Ʈ ī��Ʈ ����
        if (Input.GetMouseButtonDown(0))
        {
            _bits += bitsCount;
            mat.SetFloat("_Bits", _bits);
        }

        // ���콺 ������ Ŭ�� �� �̹��� ��ȯ
        else if(Input.GetMouseButtonDown (1))
        {
            // �̹��� ��ȯ���� �� �ʱ�ȭ
            _bits = startBitsCount;
            mat.SetFloat("_Bits", startBitsCount);

            textureCount++;
            if (textureCount >= textureList.Count)
            {
                textureCount = 0;
            }

            _selectedTexture = textureList[textureCount];
            mat.SetTexture("_MainTex", _selectedTexture);
        }
    }
}
