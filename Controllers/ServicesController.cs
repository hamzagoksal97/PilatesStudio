using Microsoft.AspNetCore.Mvc;

namespace PilatesStudio.Controllers;

public class ServicesController : Controller
{
    // GET
    public IActionResult Index(string service)
    {
        var model = new ServiceModel();
        if (service == "1")
        {
            model.Name = "Klinik Pilates";
            model.Description =
                "Fizyoterapist eşliğinde Klinik Pilates programları sunuyoruz. Kişisel sağlık sorunlarınıza özel çözümlerle vücudunuzun gücünü ve esnekliğini artırın.";
            model.Content =
                "Klinik Pilates, özellikle fiziksel terapi ve rehabilitasyon süreçlerinde kullanılan özelleştirilmiş bir pilates formudur. Çekmeköy Taşdelen'deki 3Pilates Studio, bu özel pilates yöntemini, bireylerin özgün sağlık sorunlarına ve hedeflerine yönelik programlarla sunmaktadır. Profesyonel fizyoterapistlerimiz eşliğinde, her biri kişisel sağlık durumunuza ve iyileşme sürecinize uygun şekilde tasarlanmış Klinik Pilates dersleriyle, vücudunuzun güçlenmesine ve esnekliğin artmasına yardımcı oluyoruz.\n\nKlinik Pilates'in temel faydaları arasında, postür düzeltme, omurga sağlığının desteklenmesi, kas dengesizliklerinin giderilmesi ve kronik ağrıların azaltılması yer alır. Ayrıca, bu yöntem, operasyon sonrası iyileşme süreçlerinde ve spesifik sağlık koşullarında, bireylere özel egzersiz planlarıyla önemli katkılar sağlamaktadır.\n\n3Pilates Studio, Klinik Pilates'i, bireylerin yaşam kalitesini artırma ve sağlık hedeflerine ulaşmada etkili bir araç olarak görüyor. Çekmeköy Taşdelen'deki modern ve donanımlı stüdyomuzda, sizleri güvenli ve destekleyici bir ortamda ağırlamaktan mutluluk duyarız. Klinik Pilates ile fiziksel ve zihinsel iyileşme sürecinize katkıda bulunmak ve sağlıklı bir yaşam sürdürmenize yardımcı olmak için buradayız.";
            return View(model);
        }

        if (service == "2")
        {
            model.Name = "Reformer Pilates";
            model.Description =
                "Bireysel sağlık ve zindelik hedeflerinize ulaşmanızı sağlar. Modern ekipmanlarımız ve kişiselleştirilmiş ders programlarımızla tanışın.";
            model.Content =
                "Reformer Pilates, pilatesin en etkili ve yenilikçi formlarından biri olarak bilinir. Çekmeköy Taşdelen'deki 3Pilates Studio, bu benzersiz egzersiz metodunu bireylerin sağlık, esneklik ve güç kazanmaları için kullanıyor. Reformer Pilates, özel olarak tasarlanmış bir alet olan Reformer üzerinde yapılır ve direnç bandları, kayar platform ve diğer ekipmanlar aracılığıyla vücudu güçlendirir, esnekliği artırır ve postürü iyileştirir.\n\n3Pilates Studio, Reformer Pilates'i her yaştan ve her seviyeden bireylere sunar. Stüdyomuz, kişisel hedeflerinize ve ihtiyaçlarınıza göre özelleştirilmiş ders planlarıyla, bire bir özel derslerden grup derslerine kadar çeşitli seçenekler sunmaktadır. Deneyimli eğitmenlerimiz, her dersin güvenli ve etkili bir şekilde gerçekleşmesini sağlar.\n\nReformer Pilates'in sunduğu faydalar arasında, gelişmiş kas tonusu, daha iyi postür, artan esneklik ve daha düşük stres seviyeleri bulunur. Ayrıca, bu yöntem, özellikle bel ve sırt sağlığını destekleyerek, kronik ağrıların hafifletilmesine yardımcı olabilir.\n\n3Pilates Studio, sağlıklı bir yaşam tarzı yolculuğunuzda size rehberlik etmek için burada. Çekmeköy Taşdelen'de yer alan modern stüdyomuz, sizi ve sağlık hedeflerinizi desteklemek için tasarlandı. Reformer Pilates'in gücünü deneyimlemek ve vücudunuzun potansiyelini keşfetmek için bizimle iletişime geçin.";
            return View(model);
        }

        if (service == "3")
        {
            model.Name = "Çocuk Pilates";
            model.Description =
                "Çocuklarınızın sağlıklı büyüme ve gelişimine katkıda bulunun. Çocuk Pilates derslerimizle miniklerinizi destekleyin.";
            model.Content =
                "Çocuk pilatesi, fiziksel gelişim ve sağlıklı yaşam alışkanlıklarının temellerini atmak için harika bir yöntemdir. Bu egzersizler, çocukların esnekliklerini artırarak kas-iskelet sisteminin düzgün gelişimine katkıda bulunur. Aynı zamanda duruş bozukluklarını önlemeye, dengeyi ve koordinasyonu geliştirmeye yardımcı olur. Pilates, odaklanmayı ve beden farkındalığını teşvik eder, bu da çocukların özgüvenini ve stres yönetimini iyileştirir. Eğlenceli ve güvenli bir ortamda yapılan bu aktiviteler, çocukların sporla pozitif bir ilişki kurmasına da katkı sağlar.";
            return View(model);
        }

        if (service == "4")
        {
            model.Name = "Fonksiyonel Antreman";
            model.Description =
                "Fonksiyonel Antrenman, günlük hayatta ihtiyaç duyduğunuz güç, esneklik ve dayanıklılığı artırır.3 Pilates Studio'da hayatınıza güç katın.";
            model.Content =
                "Fonksiyonel Antrenman, bireylerin günlük yaşamda karşılaştıkları fiziksel zorluklara daha iyi hazırlanmalarını sağlamak için tasarlanmış bir antrenman türüdür. Çekmeköy Taşdelen'deki 3Pilates Studio, bu özel antrenman yöntemini, kişisel sağlık ve fitness hedeflerinize ulaşmanızı kolaylaştıracak şekilde sunar. Fonksiyonel antrenman programlarımız, gerçek hayatta sıklıkla kullanılan hareketleri taklit eder ve bu hareketler üzerinde çalışarak, günlük işlerinizi yaparken karşılaşabileceğiniz zorluklara karşı vücudunuzu güçlendirir.\n\nFonksiyonel Antrenmanın temel amacı, günlük yaşamda ihtiyaç duyulan kas gruplarını hedef alarak, genel vücut gücünü, esnekliği ve dengeyi artırmaktır. Bu antrenmanlar, vücut ağırlığı egzersizleri, serbest ağırlıklar ve çeşitli fitness ekipmanları kullanılarak yapılabilmekte, böylece her seviyeden katılımcıya uygun hale getirilebilmektedir.\n\n3Pilates Studio'da sunulan Fonksiyonel Antrenman programları, deneyimli eğitmenlerimiz tarafından yönetilmekte ve her bireyin fiziksel yeteneklerine göre özelleştirilmektedir. Bu bireysel yaklaşım, her katılımcının maksimum fayda sağlamasını ve antrenmanları güvenli bir şekilde tamamlamasını garanti eder.\n\nFonksiyonel Antrenman sayesinde, günlük yaşamınızda karşılaşabileceğiniz fiziksel zorluklara karşı daha hazırlıklı olacak, vücut dayanıklılığınızı artıracak ve genel sağlık durumunuzu iyileştireceksiniz. 3Pilates Studio, bu antrenmanlarla, günlük hayatınızı kolaylaştıracak güç ve esnekliği kazanmanız için ideal bir ortam sunar.\n\n3Pilates Studio, Çekmeköy Taşdelen'de fonksiyonel antrenmanın avantajlarını keşfetmek isteyen herkesi bekliyor. Günlük yaşamınıza güç katmak ve fiziksel kapasitenizi artırmak için bize katılın.";
            return View(model);
        }

        return View();
    }
}

public class ServiceModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
}