# OnlineShop by Dosmukhanbet Muhamedzhan

This project is about Online shop. At this website we can buy cars as user and create categories of products, products, delete, add, manage as admin. All website will have good design for better usability.

# RELATIONS:

User	Role	Product	Purchases	Promocode	Company	ProductImage
us_id	role_id	pr_id	pur_id	prom_id	co_id	img_id
us_name	user_id	pr_name	user_id	user_id	user_id	Image
us_surname	role_name	pr_price	pr_id	Promocode	co_name	pr_id
us_email						product_id
us_phone						
us_login						
us_password						
role_id						

User -> Role (One-to-many)
Product -> ProductImage(One-to-one)
User -> Promocode(One-to-many)
Product - Purchases - User (Many-to-many)
