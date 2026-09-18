<h2><a href="https://leetcode.com/problems/determine-if-two-strings-are-close">Determine if Two Strings Are Close</a></h2> <img src='https://img.shields.io/badge/Difficulty-Medium-orange' alt='Difficulty: Medium' /><hr><p>Two strings are considered <strong>close</strong> if you can attain one from the other using the following operations:</p>

<ul>
    <li>Operation 1: Swap any two <strong>existing</strong> characters.
    <ul>
        <li>For example, <code>abcde -&gt; aecdb</code></li>
    </ul>
    </li>
    <li>Operation 2: Transform <strong>every</strong> occurrence of one <strong>existing</strong> character into another <strong>existing</strong> character, and do the same with the other character.
    <ul>
        <li>For example, <code>aacabb -&gt; bbcbaa</code> (all <code>a</code>'s turn into <code>b</code>'s, and all <code>b</code>'s turn into <code>a</code>'s)</li>
    </ul>
    </li>
</ul>

<p>You can use the operations on either string as many times as necessary.</p>

<p>Given two strings, <code>word1</code> and <code>word2</code>, return <code>true</code> <em>if</em> <code>word1</code> <em>and</em> <code>word2</code> <em>are <strong>close</strong>, and</em> <code>false</code> <em>otherwise.</em></p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre>
<strong>Input:</strong> word1 = "abc", word2 = "bca"
<strong>Output:</strong> true
<strong>Explanation:</strong> You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -&gt; "acb"
Apply Operation 1: "acb" -&gt; "bca"
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre>
<strong>Input:</strong> word1 = "a", word2 = "aa"
<strong>Output:</strong> false
<strong>Explanation:</strong> It is impossible to attain word2 from word1, or vice versa, in any number of operations.
</pre>

<p><strong class="example">Example 3:</strong></p>

<pre>
<strong>Input:</strong> word1 = "cabbba", word2 = "abbccc"
<strong>Output:</strong> true
<strong>Explanation:</strong> You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -&gt; "caabbb"
Apply Operation 2: "caabbb" -&gt; "baaccc"
Apply Operation 2: "baaccc" -&gt; "abbccc"
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
    <li><code>1 <= word1.length, word2.length <= 10<sup>5</sup></code></li>
    <li><code>word1</code> and <code>word2</code> contain only lowercase English letters.</li>
</ul>
