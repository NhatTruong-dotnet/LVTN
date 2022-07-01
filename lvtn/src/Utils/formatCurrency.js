export const formatCurrency = value => {
    if (value === 0) return '0 VND'
    if (!value) return

    if (value > 999999999) {
        return `${value / 1000000000} tỷ VND`
    }
    return (+value).toLocaleString('it-IT', {
        style: 'currency',
        currency: 'VND',
    })
}
