#include "stdafx.h"
#include "stack.h"

/********************************/
/****         栈的实现       ****/
/********************************/
// 初始化栈的大小和栈底
pstack init_stack(int size)
{
    pnode top_node = NULL;
    pstack stack = NULL;
    top_node = (pnode)malloc(sizeof(node));
    if (top_node == NULL)
    {
        return NULL;
    }

    stack = (pstack)malloc(sizeof(stack));
    if (stack == NULL)
    {
        return NULL;
    }

    top_node->ivex = VERTEX_INDEX_INVALID;
    top_node->next = NULL;
    stack->size = size;
    stack->ptop = top_node;
    return stack;
}

// 判断栈是否为空
bool check_stack_empty(pstack stack)
{
    if ((stack == NULL) || (stack->ptop == NULL))
    {
        return false;
    }
    
    if(stack->ptop->next == NULL)
    {
        return true;
    }

    return false;
}

// 压栈操作
void push_stack(pstack stack, int vex_index)
{
    if (stack == NULL)
    {
        return;
    }
    
    pnode vex_node = (pnode)malloc(sizeof(node));
    if (vex_node == NULL)
    {
        return;
    }
    
    vex_node->ivex = vex_index;
    vex_node->next =stack->ptop;
    stack->ptop = vex_node;
    return;
}

// 弹栈操作
int pop_stack(pstack stack)
{
    int vex_index = VERTEX_INDEX_INVALID;
    
    if(!check_stack_empty(stack))
    {
        pnode vex_node = stack->ptop;
        stack->ptop=stack->ptop->next;
        vex_index = vex_node->ivex;
        free(vex_node);
    }
 
    return vex_index;
}
