using System.Net.Http;
using System.Threading.Tasks;
using Pcf.ReceivingFromPartner.Integration.Dto;
using Pcf.ReceivingFromPartner.Core.Abstractions.Gateways;
using Pcf.ReceivingFromPartner.Core.Domain;
using Pcf.ReceivingFromPartner.Integration.Services;

namespace Pcf.ReceivingFromPartner.Integration
{
    public class GivingPromoCodeToCustomerGateway
        : IGivingPromoCodeToCustomerGateway
    {
        private readonly HttpClient _httpClient;
        private readonly IPromocodeService _promocodeService;

        public GivingPromoCodeToCustomerGateway(HttpClient httpClient, IPromocodeService promocodeService)
        {
            _httpClient = httpClient;
            _promocodeService = promocodeService;
        }

        public async Task GivePromoCodeToCustomer(PromoCode promoCode)
        {
            await _promocodeService.Create(promoCode);
            //var dto = new GivePromoCodeToCustomerDto()
            //{
            //    PartnerId = promoCode.Partner.Id,
            //    BeginDate = promoCode.BeginDate.ToShortDateString(),
            //    EndDate = promoCode.EndDate.ToShortDateString(),
            //    PreferenceId = promoCode.PreferenceId,
            //    PromoCode = promoCode.Code,
            //    ServiceInfo = promoCode.ServiceInfo,
            //    PartnerManagerId = promoCode.PartnerManagerId
            //};

            //var response = await _httpClient.PostAsJsonAsync("api/v1/promocodes", dto);

            //response.EnsureSuccessStatusCode();
        }
    }
}