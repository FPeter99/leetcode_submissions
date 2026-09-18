<h2><a href="https://leetcode.com/problems/group-anagrams">Group Anagrams</a></h2> <img src='https://img.shields.io/badge/Difficulty-Medium-orange' alt='Difficulty: Medium' /><hr><p>Given an array of strings <code>strs</code>, group <strong>the anagrams</strong> together. You can return the answer in <strong>any order</strong>.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<div>
<p><strong>Input:</strong> strs = ["eat","tea","tan","ate","nat","bat"]</p>

<p><strong>Output:</strong> [["bat"],["nat","tan"],["ate","eat","tea"]]</p>

<p><strong>Explanation:</strong></p>

<ul>
    <li>There is no string in strs that can be rearranged to form <code>"bat"</code>.</li>
    <li>The strings <code>"nat"</code> and <code>"tan"</code> are anagrams as they can be rearranged to form each other.</li>
    <li>The strings <code>"ate"</code>, <code>"eat"</code>, and <code>"tea"</code> are anagrams as they can be rearranged to form each other.</li>
</ul>
</div>

<p><strong class="example">Example 2:</strong></p>

<div>
<p><strong>Input:</strong> strs = [""]</p>

<p><strong>Output:</strong> [[""]]</p>
</div>

<p><strong class="example">Example 3:</strong></p>

<div>
<p><strong>Input:</strong> strs = ["a"]</p>

<p><strong>Output:</strong> [["a"]]</p>
</div>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
    <li><code>1 <= strs.length <= 10<sup>4</sup></code></li>
    <li><code>0 <= strs[i].length <= 100</code></li>
    <li><code>strs[i]</code> consists of lowercase English letters.</li>
</ul>
