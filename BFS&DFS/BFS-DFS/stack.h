#pragma once
struct _node
{
    int ivex;
    struct _node *next;
};
typedef struct _node node, *pnode;

struct _stack
{
    int size;
    pnode ptop;
};
typedef struct _stack stack, *pstack;

extern pstack init_stack(int size);
extern bool check_stack_empty(pstack ps);
extern void push_stack(pstack ps, int ivex);
extern int pop_stack(pstack ps);
