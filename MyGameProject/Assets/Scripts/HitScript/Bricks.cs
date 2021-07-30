using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bricks : MonoBehaviour
{
    public Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }

    public void MakeDot(Vector3 Pos)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(Pos); // Ÿ�ϸ��� ������ǥ���� ����ǥ�� ����

        tilemap.SetTile(cellPosition, null); // SetTile�� ��ǥ�� null��
    }
}
