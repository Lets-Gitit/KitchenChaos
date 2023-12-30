using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private CuttingRecipeSO[] cuttingRecipeSOArray;


    public override void Interact(Player player) {
        // KitchenObject�� ������ ���� ���� ���
        if (!HasKitchenObject()) {
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            if (player.HasKitchenObject()) {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {

            }
        }
        // KitchenObject�� ������ �ִ� ���
        else {
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            if (player.HasKitchenObject()) {

            }
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
    
    public override void InteractAlternate(Player player) {
        if(HasKitchenObject()) {
            KitchenObjectSO outputKitchenSO = GetOutputForInput(GetKitchenObject().GetKitchenObjectSO());
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(outputKitchenSO, this);
        }
    }

    private KitchenObjectSO GetOutputForInput(KitchenObjectSO inputKitchenObjectSO) {
        foreach (CuttingRecipeSO cuttingRecipeSO in cuttingRecipeSOArray) {
            if(cuttingRecipeSO.input == inputKitchenObjectSO) {
                return cuttingRecipeSO.output;
            }
        }
        return null;
    }
}

