#include "stdafx.h"
#include "queue.h"

// 初始化队列，初始化一个头节点
pqueue init_queue()
{
    pnode queue_node = (pnode)malloc(sizeof(node));
    if (queue_node == NULL)
    {
        return NULL;
    }
    
    queue_node->next = NULL;
    queue_node->ivex = VERTEX_INDEX_INVALID;
    pqueue queue = (pqueue)malloc(sizeof(QUEUE));
    if (queue == NULL)
    {
        return NULL;
    }
    
    queue->front = queue->rear = queue_node;
    return queue;
}

// 检查队列是否为空
bool check_queue_empty(pqueue &queue)
{
    if(queue->front == queue->rear)
    {
        return true;
    }

    return false;
}

// 入队列尾
void en_queue(pqueue &queue, int vex_index)
{
    pnode queue_node = (pnode)malloc(sizeof(node));
    if (queue_node == NULL)
    {
        return;
    }
    
    queue_node->ivex = vex_index;
    queue_node->next = NULL;
    queue->rear->next = queue_node;
    queue->rear = queue_node;

    return;
}

// 出队列头
int de_queue(pqueue &queue)
{
    int vex_index = VERTEX_INDEX_INVALID;
    if(!check_queue_empty(queue))
    {
        pnode queue_node = queue->front;
        queue->front = queue->front->next;
        vex_index = queue_node->ivex;
        free(queue_node);
    }
    
    return vex_index;
}