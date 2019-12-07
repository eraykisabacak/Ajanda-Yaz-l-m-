# Ajanda-Yazılımı   


<!-- wp:heading {"level":3} -->
<h3> NYP ilkeleri ile geliştirilecek personel bilgilerini tutan bir Ajanda yazılımı tasarlamanız istenmektedir. Bu amaçla kullanılmak üzere aşağıda verilen Form tasarımlarını yapmalıdır. Ayrıca personel bilgilerine erişmek ve sorgulama işlemlerinde kullanmak üzere&nbsp;<strong>Personel.cs&nbsp;</strong>ve&nbsp;<strong>Ajanda.cs</strong>isminde iki sınıf tasarlanacaktır. Girilen kayıtlar dosyaya kaydedilecek ve program kapatıldığında bilgi kaybı olmayacaktır. Program yeniden çalıştırıldığında veriler dosyadan okunacak ve çalışmaya devam edecektir. Veri tabanı kullanılması&nbsp;istenmemektedir. </h3>
<!-- /wp:heading -->

<!-- wp:image {"id":230,"align":"center"} -->
<div class="wp-block-image"><figure class="aligncenter"><img src="http://eraykisabacak.com/wp-content/uploads/2019/08/C-Ajanda-Yazılımı-Personel-Girişi-ve-FileStream-Dosya-İşlemleri-1.png" alt="" class="wp-image-230"/></figure></div>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p> Program çalıştırıldığında ilk olarak Login Penceresi gelecek ve Kullanıcı Adı - Şifre eşleşmelerini&nbsp;"users.txt”&nbsp;dosyasından kontrol edilecek. Yetkili bilinen bir kullanıcı ise Login formu gizlenecek; Ana Form açılacak. </p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":231,"align":"center"} -->
<div class="wp-block-image"><figure class="aligncenter"><img src="http://eraykisabacak.com/wp-content/uploads/2019/08/C-Ajanda-Yazılımı-Personel-Girişi-ve-FileStream-Dosya-İşlemleri-2-.png" alt="" class="wp-image-231"/></figure></div>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p>Ana Formun Menustrip kontrolünde Görünüm sekmesinden yeni veri kaydı yapılacak olan Personel Kayıt Ekranına ve Arama Ekranlarına erişim sağlanacaktır.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":3} -->
<h3>Tasarlanacak&nbsp;<strong><em>Personel</em></strong>&nbsp;sınıfı için;</h3>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p><strong>a)</strong>Personel bilgilerinin ( Ad, Soyad, Doğum Tarihi, Meslek, Cinsiyet, Medeni durum ve maaş ) ve sorgulama metotlarının kodlanacağı bir sınıf tasarlayın. Tüm alanlar için uygun veri türlerini belirleyin.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>b)</strong>Sınıftaki tüm değişkenler için property tanımlamalarını yapın.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>c)</strong>Personel adını ve soyadını parametre olarak alan bir kurucu metot tanımlayın.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>d)</strong>Yaş adında bir sadece get bloğu olan bir property tanımlayın. Bu property için doğum_tarihi değişkenine bağlı olarak personelin yaşını geri dönderecek şekilde kodlamasını yapın.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>e)</strong>Cinsiyet ve Medeni Durum alanları için enum tanımları yapın.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>f)</strong>ZamYap, KalanGünSayısı, DosyadanOku, DosyayaYaz isimlerinde 4 metot tasarlamanız gerekmektedir:</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>ZamYap Metodu:&nbsp;</strong>Parametre olarak verilen miktar kadar personelin maaş değişkeninin değerini günceller.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>KalanGünSayısı Metodu:&nbsp;</strong>57 yaş baz alınarak personelin emekliliğine kalan gün sayısını hesaplar ve geri dönüş değeri olarak verir.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>DosyadanOku Metodu:&nbsp;</strong>Belirli bir konumda tutulan&nbsp;"data.txt”&nbsp;isimli dosyadan kayıtların tamamını okur ve her biri için Personel nesnesi oluşturur. Bunları Personel tipinde bir diziye yerleştirip ve bu diziyi geri dönüş değeri olarak verir. Amacı program başlangıcında kayıtların okunmasıdır.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>i.</strong>Birinci yöntem olarak; burada henüz bilmediğiniz (!) Generic List yapılarını araştırıp kullanabilirsiniz.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Örnek:</strong>&nbsp;List&lt;Personel&gt; liste = new List&lt;Personel&gt;();</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>ii.</strong>İkinci bir yöntem olarak; dosyanın ilk satırında toplam kayıt sayısını tutarak kaç elemanlı bir dizi oluşturacağınızı bilebilirsiniz.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Örnek:</strong><strong></strong>Personel[] kayıt= new Personel[1000];</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>iii.</strong>Bu biçimlendirmeyi okumak için String sınıfının Split metodundan faydalanabilirsiniz.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>DosyayaYaz Metodu:&nbsp;</strong>Personel kayıt listesini parametre olarak alır ve&nbsp;"data.txt”isimli dosyaya aşağıdaki biçimlendirmeye uygun şekilde herbir satıra bir kayıt olacak biçimde dosyayı oluşturur.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong><em>Örnek Kayıt Biçimlendirmesi şu şekilde olmalıdır:</em></strong></p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>ad | soyad | dogum_tarihi | meslek | cinsiyet | medeni_durum | maas | email | adres | telefonlar</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong><em>Burada telefonlar ajanda nesnesinden alınacağı için birden fazla olabilir:</em></strong></p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>telefonlar : telAdı1,telNo1 + telAdı2,telNo2 + telAdı3,telNo3</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong><em>Bu biçimlendirmeyi oluşturmak için String sınıfının Join metodundan faydalanabilirsiniz.</em></strong></p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>Bir personelin birden fazla telefon bilgisi (ev, iş, GSM, GSM2, vb.) olabilir. Bu nedenle telefonları tutmak amacıyla&nbsp;<strong>Ajanda.cs&nbsp;</strong>isminde bir sınıf tasarlamanız istenmektedir. Ajanda sınıfında telefonAdı ve telefonNo isimli uygun türlerde iki değişken tanımlamasını ve bu değişkenlerin property tanımlamalarını yapınız. Ayrıca uygun bir kurucu metot tanımlayınız.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Örnek:</strong><strong></strong>telefonAdı = ev , telefonNo = 332 223 33 36</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>Daha sonra Personel sınıfı içinde bir Ajanda dizisi oluşturun ve o personele ait telefonları bu diziye ekleyin. (<strong>Not:</strong>Ajanda dizisini generic list olarak veya 10 elemanlı bir dizi olarak oluşturabilirsiniz. )</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>DİKKAT EDİLMESİ GEREKENLER</strong></p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>1.</strong>Ana Form MdiParent olarak, diğerleri child formlar olarak çalışacaktır.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>2.</strong>Sınıflar için yukarıda tanımlayacağınız metot ve değişkenlerin tamamı form arayüzünde kullanılmayacak olabilir. Önemli olan sizden istenilenlerin eksiksiz yapılmasıdır.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>3.</strong>Personel Kayıt işlemi aşağıda tasarımı görülen form üzerinden yapılacaktır. Bu esnada tasarlanacak olan Personel ve Ajanda sınıflarının kullanılması zorunludur.&nbsp;Sınıflar kullanılmadan yapılan ödevler bütünüyle geçersiz sayılacaktır.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>4.</strong>Personel Kayıt Arama Ekranında personel adına göre arama işlemi yapılacak; ilk bulunan kayıt bilgileri yeni bir FormKayıt Penceresi içinde gösterilecektir.</p>
<!-- /wp:paragraph -->


<!-- wp:paragraph -->
<p><strong>5.</strong>Dosya adı: öğrenci_numarası.rar şeklinde olmalıdır.</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":232,"align":"center"} -->
<div class="wp-block-image"><figure class="aligncenter"><img src="http://eraykisabacak.com/wp-content/uploads/2019/08/C-Ajanda-Yazılımı-Personel-Girişi-ve-FileStream-Dosya-İşlemleri-3.png" alt="" class="wp-image-232"/></figure></div>
<!-- /wp:image -->

http://eraykisabacak.com/c-ajanda-yazilimi-personel-girisi-ve-filestream-dosya-islemleri/
