#pragma once

#include "stack.h"
#include "queue.h"

/********************************/
/****      图的结构定义      ****/
/********************************/

struct _ArcCell
{
    VRType adj; // 边的权值
    InfoType *info; // 边的其他信息
};

typedef struct _ArcCell ArcCell, AdjMatrix[MAX_VEX][MAX_VEX];

struct _MGraph
{
    VertexType vexs[MAX_VEX]; // 用字符标记节点 
    bool is_visited[MAX_VEX]; // 标记是否被访问过
    AdjMatrix arcs; // 二维数组定义边，边的权值为INFINITY表示不相连，其他则表示连通
    int vexnum; // 节点个数
    int arcnum; // 边的个数
};

typedef struct _MGraph MGraph;

extern MGraph create_graph();
extern int locate_vertex(MGraph &, char);
extern void depth_first_search(MGraph &);
extern void depth_first_search_by_stack(MGraph &);
extern void breadth_first_search_by_queue(MGraph &);
extern bool check_connect(MGraph &, int, int);
extern void init_visited_record(MGraph &);