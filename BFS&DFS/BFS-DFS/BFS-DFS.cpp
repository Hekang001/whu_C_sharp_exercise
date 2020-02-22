// BFS-DFS.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "graph.h"
#include "queue.h"
#include "stack.h"

int _tmain(int argc, _TCHAR* argv[])
{
    MGraph graph;

    // 创建无向权重图
    graph = create_graph();

    // 深度优先搜索的递归方式遍历
    printf("\nDFS: ");
    depth_first_search(graph);

    // 深度优先搜索的栈方式非递归方式遍历
    printf("\nDFS: ");
    depth_first_search_by_stack(graph);

    // 广度优先搜索的队列非递归方式遍历
    printf("\nBFS: ");
    breadth_first_search_by_queue(graph);
    printf("\n");

    // 调试暂停
    getchar();
    return 0;
}

