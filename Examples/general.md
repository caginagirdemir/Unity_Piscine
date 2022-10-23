# Genel

Unity de herşey bir object tir. 

Bir Objectin temel ve zorunlu componenti Transformdur.

private void Awake() Start fonksiyonundan da önce çalışır
private void FixedUpdate() Sabit kare sayısında çalışır
private void LateUpdate() Update fonksiyonundan sonra çalışır

private void OnCollisionEnter() Atanan objenin collider alanına girildiğinde tetiklenir ve Trigger durumu açılmak zorunda değildir.

private void OnTriggerEnter() Atanan objenin collider componentindeki IsTrigger tik i aktif edilmelidir.

abstract class bir kere miras alınabilir. Eğer abstract class ın bir fonksiyonu override olacaksa asbtract içinde virtual olarak belirtilmelidir.

eğer birden fazla inheritance gereksiyorsa interface oluşturmalıyız. Interface class isimleri I ile başlar. 

Invoke(FunctionName, Time(as second)) belirtilen süreyi saniye olarak bekler ve fonksiyonu çalıştırır
