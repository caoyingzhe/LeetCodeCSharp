﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeNode = CSharpConsoleApp.Solutions.SolutionBase.TreeNode;

namespace CSharpConsoleApp.Solutions._0200
{
    /*
     * @lc app=leetcode.cn id=297 lang=csharp
     *
     * [297] 二叉树的序列化与反序列化
     *
     * https://leetcode-cn.com/problems/serialize-and-deserialize-binary-tree/description/
     *
     * algorithms
     * Hard (54.23%)
     * Likes:    540
     * Dislikes: 0
     * Total Accepted:    76.4K
     * Total Submissions: 140.4K
     * Testcase Example:  '[1,2,3,null,null,4,5]'
     *
     * 
     * 序列化是将一个数据结构或者对象转换为连续的比特位的操作，进而可以将转换后的数据存储在一个文件或者内存中，同时也可以通过网络传输到另一个计算机环境，采取相反方式重构得到原数据。
     * 
     * 请设计一个算法来实现二叉树的序列化与反序列化。这里不限定你的序列 /
     * 反序列化算法执行逻辑，你只需要保证一个二叉树可以被序列化为一个字符串并且将这个字符串反序列化为原始的树结构。
     * 
     * 提示: 输入输出格式与 LeetCode 目前使用的方式一致，详情请参阅 LeetCode
     * 序列化二叉树的格式。你并非必须采取这种方式，你也可以采用其他的方法解决这个问题。
     * 
     * 
     * 
     * 示例 1：
     * 
     * 
     * 输入：root = [1,2,3,null,null,4,5]
     * 输出：[1,2,3,null,null,4,5]
     * 
     * 
     * 示例 2：
     * 
     * 
     * 输入：root = []
     * 输出：[]
     * 
     * 
     * 示例 3：
     * 
     * 
     * 输入：root = [1]
     * 输出：[1]
     * 
     * 
     * 示例 4：
     * 
     * 
     * 输入：root = [1,2]
     * 输出：[1,2]
     * 
     * 
     * 
     * 
     * 提示：
     * 
     * 
     * 树中结点数在范围 [0, 10^4] 内
     * -1000 
     * 
     * 
     */

    // @lc code=start
    /**
        * Definition for a binary tree node.
        * public class TreeNode {
        *     public int val;
        *     public TreeNode left;
        *     public TreeNode right;
        *     public TreeNode(int x) { val = x; }
        * }
        */
    class Solution297 : SolutionBase
    {
        public override bool Test(System.Diagnostics.Stopwatch sw)
        {
            bool isSuccess = true;
            int num = 0;

            TreeNode node = new TreeNode();

            Codec obj = new Codec();
            string data = obj.serialize(node);
            TreeNode des = obj.deserialize(data);

            return isSuccess;
        }
    }

    public class Codec
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return "";
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            int[] arr = new int[] { }; // from data
            return new TreeNode();
        }
    }
}