import { FaBuilding, FaBabyCarriage } from 'react-icons/fa'
import { MdShoppingBag, MdPets } from 'react-icons/md'
import { RiMotorbikeFill, RiFridgeFill } from 'react-icons/ri'
import { GoDeviceDesktop } from 'react-icons/go'
import { SiYourtraveldottv } from 'react-icons/si'
import {
    GiForkKnifeSpoon,
    GiSofa,
    GiDress,
    GiConsoleController,
    GiSewingMachine,
} from 'react-icons/gi'
import RealEstate from '../../features/Post/FormComponents/RealEstate'
import Vehicle from '../../features/Post/FormComponents/Vehicle/Vehicle'
import ElectronicDevice from '../../features/Post/FormComponents/ElectronicDevice/ElectronicDevice'
import Job from '../../features/Post/FormComponents/Job/Job'
import Pet from '../../features/Post/FormComponents/Pet/Pet'
import Food from '../../features/Post/FormComponents/Food/Food'
import HouseWare from '../../features/Post/FormComponents/Houseware/Houseware'
import Furniture from '../../features/Post/FormComponents/Furniture/Furniture'
import MomAndBaby from '../../features/Post/FormComponents/MomAndBaby/MomAndBaby'
import Fashion from '../../features/Post/FormComponents/Fashion/Fashion'
import Entertainment from '../../features/Post/FormComponents/Entertainment/Entertainment'
import Requisite from '../../features/Post/FormComponents/RequisiteAndIndustryAndAgriculture'

const categories = [
    {
        id: 1,
        name: 'Bất động sản',
        Icon: FaBuilding,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <RealEstate
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            {
                id: 13,
                name: 'Căn hộ, chung cư',
            },
            { id: 14, name: 'Nhà ở' },
            { id: 15, name: 'Đất' },
            { id: 16, name: 'Văn phòng, mặt bằng kinh doanh' },
            { id: 17, name: 'Phòng trọ' },
        ],
    },
    {
        id: 2,
        name: 'Xe cộ',
        Icon: RiMotorbikeFill,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Vehicle
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 18, name: 'Ô tô' },
            { id: 19, name: 'Xe máy' },
            { id: 20, name: 'Xe tải, Xe ben' },
            { id: 21, name: 'Xe điện' },
            { id: 22, name: 'Xe đạp' },
            { id: 23, name: 'Phương tiện khác' },
            { id: 24, name: 'Phụ tùng xe' },
        ],
    },
    {
        id: 3,
        name: 'Đồ điện tử',
        Icon: GoDeviceDesktop,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <ElectronicDevice
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 25, name: 'Điện thoại' },
            { id: 26, name: 'Máy tính bảng' },
            { id: 27, name: 'Laptop' },
            { id: 28, name: 'Máy tính để bàn' },
            { id: 29, name: 'Máy ảnh, máy quay' },
            { id: 30, name: 'Tivi, Âm thanh' },
            { id: 31, name: 'Thiết bị đeo thông minh' },
            { id: 32, name: 'Phụ kiện (Màn hình, Chuột.... )' },
            { id: 33, name: 'Linh kiện (RAM, Card, ... )' },
        ],
    },
    {
        id: 4,
        name: 'Việc làm',
        Icon: MdShoppingBag,
        subCategory: null,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Job
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
    },
    {
        id: 5,
        name: 'Thú cưng',
        Icon: MdPets,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Pet
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 34, name: 'Gà' },
            { id: 35, name: 'Chó' },
            { id: 36, name: 'Chim' },
            { id: 37, name: 'Mèo' },
            { id: 38, name: 'Thú cưng khác' },
            { id: 39, name: 'Phụ kiện, Thức ăn, Dịch vụ' },
        ],
    },
    {
        id: 6,
        name: 'Đồ ăn, thực phẩm các loại',
        Icon: GiForkKnifeSpoon,
        subCategory: null,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Food
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
    },
    {
        id: 7,
        name: 'Tủ lạnh, máy lạnh, máy giặt',
        Icon: RiFridgeFill,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <HouseWare
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),

        subCategory: [
            { id: 40, name: 'Tủ lạnh' },
            { id: 41, name: 'Máy lạnh, điều hòa' },
            { id: 42, name: 'Máy giặt' },
        ],
    },
    {
        id: 8,
        name: 'Đồ gia dụng, nội thất, cây cảnh',
        Icon: GiSofa,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Furniture
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 43, name: 'Bàn ghế' },
            { id: 44, name: 'Tủ, kệ gia đình' },
            { id: 45, name: 'Giường, chăn ga gối nệm' },
            { id: 46, name: 'Bếp, lò, đồ điện nhà bếp' },
            { id: 47, name: 'Dụng cụ nhà bếp' },
            { id: 48, name: 'Quạt' },
            { id: 49, name: 'Đèn' },
            { id: 50, name: 'Cây cảnh, đồ trang trí' },
            { id: 51, name: 'Thiết bị vệ sinh, nhà tắm' },
            { id: 52, name: 'Nội thất, đồ gia dụng khác' },
        ],
    },
    {
        id: 9,
        name: 'Mẹ và bé',
        Icon: FaBabyCarriage,
        subCategory: null,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <MomAndBaby
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
    },
    {
        id: 10,
        name: 'Thời trang, đồ dùng cá nhân',
        Icon: GiDress,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Fashion
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 53, name: 'Quần áo' },
            { id: 54, name: 'Đồng hồ' },
            { id: 55, name: 'Giày dép' },
            { id: 56, name: 'Túi xách' },
            { id: 57, name: 'Nước hoa' },
            { id: 58, name: 'Phụ kiện thời trang khác' },
        ],
    },
    {
        id: 11,
        name: 'Giải trí, thể thao, sở thích',
        Icon: GiConsoleController,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Entertainment
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 59, name: 'Nhạc cụ' },
            { id: 60, name: 'Sách' },
            { id: 61, name: 'Đồ thể thao, dã ngoại' },
            { id: 62, name: 'Đồ sưu tầm, đồ cổ' },
            { id: 63, name: 'Thiết bị chơi game' },
            { id: 64, name: 'Sở thích khác' },
        ],
    },
    {
        id: 12,
        name: 'Đồ dùng văn phòng, công nông nghiệp',
        Icon: GiSewingMachine,
        Component: (subCategoryId, formData, handleFormDataChange) => (
            <Requisite
                subCategoryId={subCategoryId}
                formData={formData}
                handleFormDataChange={handleFormDataChange}
            />
        ),
        subCategory: [
            { id: 65, name: 'Đồ dùng văn phòng' },
            { id: 66, name: 'Đồ chuyên dụng, Giống nuôi trồng' },
        ],
    },
    {
        id: 13,
        name: 'Dịch vụ, du lịch',
        Icon: SiYourtraveldottv,
        subCategory: null,
    },
]

export default categories
