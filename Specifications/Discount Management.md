***Discount Management***
<p><ac:structured-macro ac:macro-id="0197e860-a3e5-44dd-8fef-2b600f11d322" ac:name="toc" ac:schema-version="1" /></p>
<h1>Discounts/ Coupon Setup in WooCommerce</h1>
<p>Ref: <a href="https://woocommerce.com/posts/coupons-with-woocommerce/">https://woocommerce.com/posts/coupons-with-woocommerce/</a></p>
<h2>Percentage Discount</h2>
<p>Percentage discounts apply a percentage discount to the entire cart.</p>
<ul>
<li>If there are no Usage Restrictions, Percentage discounts will be added to each item line.</li></ul>
<p style="margin-left: 30.0px;">e.g: When there are two Product Lines and Cart Discount (Coupon) Amount is 10%, each line will have a discount based on the percentage.</p>

![Screenshot](/Specifications/Spec%20Images/Discounts1.png)

<ul>
<li>If there are Usage Restrictions, Percentage discounts will be added to each item line based on the restrictions.<br />e.g: When a Percentage discount (10%) is only allowed for a particular product, the discount is applied for that product only.</li></ul>

![Screenshot](/Specifications/Spec%20Images/Discounts2.png)

<p>&nbsp;</p>
<h2>Fixed Cart Discounts</h2>
<p>Apply a fixed amount discount to the entire cart.</p>
<p>Even if the cart has more than one product line. The total discount applied to the entire cart will be allocated to the available number of lines. And this cannot be applied only to one line.</p>

![Screenshot](/Specifications/Spec%20Images/Discounts3.png)

<h2>Fixed Product Discounts</h2>
<p>Apply a fixed amount discount to <strong>selected products only</strong>. The <strong>discount is calculated per item</strong> and<strong> not for the whole cart.</strong></p>
<p>The amount of discount is applied only to the specified product item only.</p>

![Screenshot](/Specifications//Spec%20Images/Discounts4.png)

<p>&nbsp;</p>
<h2>Solution - Discount Data Fetching to Acumatica Sales Order</h2>
<ul>
<li>When <strong style="font-size: 14.0px;">Line Discount</strong><span style="font-size: 14.0px;"> selected in WooCommerce Store settings</span></li></ul>
<p>Discount Amount will be fetched to <em>Document Details&gt; Discount Amount</em></p>
<p><em>When Line Discount</em> is used, the following formula can be used to get the discount amount for a particular product item.</p>
<p>&nbsp;</p>
<p><strong>&ldquo;subtotal&rdquo; &ndash; &ldquo;total&rdquo; = &ldquo;discount&rdquo;</strong></p>

![Screenshot](/Specifications/Spec%20Images/Discounts5.png)

<p>&nbsp;</p>
<ul>
<li>When <strong>Document Discount</strong> selected in WooCommerce Store settings (Customer Discount Feature should be enabled)</li></ul>
<p>Discount Amount will be fetched to <em>Discount Details&gt; Discount Amt.</em></p>
<p>For this &ldquo;Coupon Lines&rdquo; can be used.</p>

![Screenshot](/Specifications/Spec%20Images/Discounts6.png)

<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
